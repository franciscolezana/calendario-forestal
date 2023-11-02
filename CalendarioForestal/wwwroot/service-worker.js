// Caution! Be sure you understand the caveats before publishing an application with
// offline support. See https://aka.ms/blazor-offline-considerations

self.importScripts('./service-worker-assets.js');
self.addEventListener('install', event => event.waitUntil(onInstall(event)));
self.addEventListener('activate', event => event.waitUntil(onActivate(event)));
self.addEventListener('fetch', event => event.respondWith(onFetch(event)));

const version = '0_0_16-';

const cacheNamePrefix = 'offline-cache-';
const cacheGETRequestsPrefix = 'GET-requests-cache-';
const cacheName = `${cacheNamePrefix}${self.assetsManifest.version}`;
const cacheGETName = `${cacheGETRequestsPrefix}${version}${self.assetsManifest.version}`;

const offlineAssetsInclude = [/\.dll$/, /\.pdb$/, /\.wasm/, /\.html/, /\.js$/, /\.json$/, /\.css$/, /\.woff$/, /\.png$/, /\.jpe?g$/, /\.gif$/, /\.ico$/, /\.blat$/, /\.dat$/];
const offlineAssetsExclude = [/^service-worker\.js$/];

async function onInstall(event) {
    console.info('Service worker: Install');

    // Fetch and cache all matching items from the assets manifest
    const assetsRequests = self.assetsManifest.assets
        .filter(asset => offlineAssetsInclude.some(pattern => pattern.test(asset.url)))
        .filter(asset => !offlineAssetsExclude.some(pattern => pattern.test(asset.url)))
        .map(asset => new Request(asset.url, { integrity: asset.hash, cache: 'no-cache' }));
    await caches.open(cacheName).then(cache => cache.addAll(assetsRequests));
}

async function onActivate(event) {
    console.info('Service worker: Activate');

    // Delete unused caches
    const cacheKeys = await caches.keys();
    await Promise.all(cacheKeys
        .filter(key =>
            (key.startsWith(cacheNamePrefix) && key !== cacheName) ||
            (key.startsWith(cacheGETRequestsPrefix) && key !== cacheGETName)
        )
        .map(key => caches.delete(key)));
}

async function onFetch(event) {
    console.info('Service worker: Fetching');
    let cachedResponse = null;
    const isAPIGetRequest = event.request.url.includes('api/');
    if (event.request.method === 'GET' && !isAPIGetRequest) {
        // For all navigation requests, try to serve index.html from cache
        // If you need some URLs to be server-rendered, edit the following check to exclude those URLs
        const shouldServeIndexHtml = event.request.mode === 'navigate';

        const request = shouldServeIndexHtml ? 'index.html' : event.request;
        const cache = await caches.open(cacheName);
        cachedResponse = await cache.match(request);
    }
    else if (isAPIGetRequest) {
        const cache = await caches.open(cacheGETName);
        cachedResponse = await cache.match(event.request);
        if (cachedResponse !== undefined) {
            console.log('si hay cache y refresca');
            fetch(event.request).then(response => {
                console.log('se refresco');
                cache.put(event.request, response.clone());
            });
        }

    }
    return cachedResponse || fetch(event.request).then(async response => {
        if (isAPIGetRequest) {
            const cache = await caches.open(cacheGETName);
            await cache.put(event.request, response.clone());
        }
        return response;
    });
}
