window.zoomImage = (image, scale) => {
    const element = image.getNativeElement();
    element.style.transform = `scale(${scale})`;
};