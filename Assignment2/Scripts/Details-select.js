/*Details页面菊仙/袁四爷内容选择*/
// 获取所有图片元素
const images = document.querySelectorAll('.image');
const moreXian = document.querySelector('.moreXian');
const moreSiye = document.querySelector('.moreSiye');

let xianVisible = false;
let siyeVisible = false;

// 为每个图片添加点击事件监听器
images.forEach(image => {
    image.addEventListener('click', () => {
        const imageId = image.id;
        if (imageId === 'xian') {
            if (xianVisible) {
                moreXian.style.display = 'none';
                xianVisible = false;
            } else {
                moreXian.style.display = 'block';
                xianVisible = true;
            }
            moreSiye.style.display = 'none';
            siyeVisible = false;
        } else if (imageId === 'siye') {
            if (siyeVisible) {
                moreSiye.style.display = 'none';
                siyeVisible = false;
            } else {
                moreSiye.style.display = 'block';
                siyeVisible = true;
            }
            moreXian.style.display = 'none';
            xianVisible = false;
        }
    });
});