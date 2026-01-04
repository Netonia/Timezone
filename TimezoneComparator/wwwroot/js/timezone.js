window.getBrowserTimezone = () => {
    try {
        return Intl.DateTimeFormat().resolvedOptions().timeZone;
    } catch (e) {
        console.error('Error getting browser timezone:', e);
        return null;
    }
};

window.setTheme = (theme) => {
    document.documentElement.setAttribute('data-theme', theme);
    localStorage.setItem('theme', theme);
};

window.getTheme = () => {
    return localStorage.getItem('theme') || 'light';
};
