
var osm = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
    maxZoom: 18
});

var googleSatLayer = L.tileLayer('http://{s}.google.com/vt/lyrs=s&x={x}&y={y}&z={z}', {
    maxZoom: 20,
    subdomains: ['mt0', 'mt1', 'mt2', 'mt3']
});

var miniMapLayerOSM = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors',
    maxZoom: 18
});

var miniMapLayerGoogle = L.tileLayer('http://{s}.google.com/vt/lyrs=s&x={x}&y={y}&z={z}', {
    maxZoom: 20,
    subdomains: ['mt0', 'mt1', 'mt2', 'mt3']
});

var map = L.map('map', {
    center: [10.590812687530157, -74.18780172831298],
    zoom: 4,
    layers: [osm],
    scrollWheelZoom: true,
    zoomControl: false
});

const baseMaps = {
    "OpenStreetMap": osm,
    "Google Satellite": googleSatLayer
};

const overlayMaps = {

};

L.control.layers(baseMaps, overlayMaps, { position: 'topright', collapsed: true }).addTo(map);

L.control.scale({ position: 'bottomleft', imperial: false }).addTo(map);

L.control.zoom({
    position: 'topright'
}).addTo(map);

L.control.fullscreen({
    position: 'topright'
}).addTo(map);

L.control.locate({ flyTo: true, position: 'topright' }).addTo(map);
