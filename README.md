# Scene-Rendering-With-Raycasting

Trackers: kd, ks, m change light reflection model parameters.
Tracker z changes hight of the light source

Interpolation group box:
If 'interpolate normal vectors' is checked, then: colors within each triangle are computed by interpolating normal vectors in vertices and then using such interpolated vector color is generated (accuare, but slow)
If 'interpolate color' is checked, then: color is generated by interpolating colors of vertices (inaccurate and blury, but fast)

Color group box:
If You click 'Color from Texture', then You are promped to provide Your own bitmap to be displayed over the surface, to change current bitmap to new, click this radio button again.
If You click 'Constant Color', then You are prompted to chose color from color pallet, this will be color of whole displayed bitmap.

'Paint triangulation' checkbox allows to swich on/off paint of surface triangulation.

'Animation' checkbox allows to start/stop animation of spiral move of the light source.

'Load OBJ file' button allows You to load new obj file to be used as a surface.

'Chnage Light Color' button allows You to chose new light color from color pallet.

'Load Normal Map' allows You to load new normal map to modify normals vectors of current surface.
'Use Modified Normal Vectors' allows to switch on/off modification of normal vectors.

 
