document.addEventListener('DOMContentLoaded', function () {
    const toggle = document.querySelector('.mobile-toggle');
    const nav = document.querySelector('.header nav');
    const cta = document.querySelector('.header-cta');

    if (!toggle) return;

    toggle.addEventListener('click', function () {
        const isOpen = nav.style.display === 'flex';
        nav.style.display = isOpen ? '' : 'flex';
        nav.style.flexDirection = 'column';
        nav.style.position = 'absolute';
        nav.style.top = '80px';
        nav.style.left = '0';
        nav.style.right = '0';
        nav.style.background = 'rgba(255,255,255,0.97)';
        nav.style.padding = '16px 24px';
        nav.style.borderBottom = '1px solid var(--border)';
        if (cta) cta.style.display = isOpen ? '' : 'inline-flex';
    });
});
