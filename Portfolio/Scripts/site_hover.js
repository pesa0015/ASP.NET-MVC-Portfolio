function showSiteHrefTarget(site) {
	document.getElementById('title-' + site.id).style.display = 'none';
	document.getElementById('href-target-' + site.id).style.display = 'block';
}

function showSiteTitle(site) {
	document.getElementById('title-' + site.id).style.display = 'block';
	document.getElementById('href-target-' + site.id).style.display = 'none';
}