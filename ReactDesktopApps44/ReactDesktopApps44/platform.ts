﻿interface Window {
    nativeHost: any;
}

class WebNativeHost {
    showAbout() {
        alert("ReactDesktopApps44 - ServiceStack + React");
    }

    toggleFormBorder() {}

    quit() {
        window.close();
    }
	
    ready() {}
}

window.nativeHost = window.nativeHost || new WebNativeHost();
