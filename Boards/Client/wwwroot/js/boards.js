var imageData;
function createBoard() {
	if (document.getElementById("BoardCanvas") === null) {
		// create canvas element and append it to document body
		var canvas = document.createElement('canvas');
		canvas.id = "BoardCanvas"
		document.getElementById("BoardSpace").appendChild(canvas);

		// some hotfixes... ( ≖_≖)
		document.body.style.margin = 0;
		canvas.style.position = 'fixed';

		// get canvas 2D context and set him correct size
		var ctx = canvas.getContext('2d');
		resize();

		// last known position
		var pos = { x: 0, y: 0 };

		window.addEventListener('resize', resize);
		document.addEventListener('mousemove', draw);
		document.addEventListener('mousedown', setPosition);
		document.addEventListener('mouseenter', setPosition);

		// new position from mouse event
		function setPosition(e) {
			var c = document.getElementById("BoardSpace");
			pos.x = e.clientX - c.offsetLeft;
			pos.y = e.clientY - c.offsetTop;
		}

		// resize canvas
		function resize() {
			ctx.canvas.width = window.innerWidth;
			ctx.canvas.height = window.innerHeight;
		}

		function draw(e) {
			// mouse left button must be pressed
			if (e.buttons !== 1) return;

			ctx.beginPath(); // begin

			ctx.lineWidth = 5;
			ctx.lineCap = 'round';
			ctx.strokeStyle = '#c0392b';

			ctx.moveTo(pos.x, pos.y); // from
			setPosition(e);
			ctx.lineTo(pos.x, pos.y); // to

			ctx.stroke(); // draw it!
			}
	}
}

function copyImageData() {
	var c = document.getElementById("BoardCanvas");
	var ctx = c.getContext("2d");
	imageData = ctx.getImageData(0,0,c.width,c.height)	
}

function clearBoard() {
	var c = document.getElementById("BoardCanvas");
	var ctx = c.getContext("2d");
	ctx.clearRect(0, 0, c.width, c.height);
}
function putImage(){
	var c = document.getElementById("BoardCanvas");
	var ctx = c.getContext("2d");
	ctx.putImageData(imageData, 0, 0);
}