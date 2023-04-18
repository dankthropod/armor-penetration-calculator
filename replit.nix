{ pkgs }: {
	deps = [
		pkgs.sudo
  pkgs.jq.bin
		pkgs.dotnet-sdk
		pkgs.omnisharp-roslyn
		pkgs.libgdiplus
		pkgs.glib
		pkgs.cairo
		pkgs.libexif
		pkgs.libjpeg
		pkgs.giflib
		pkgs.libtiff
		pkgs.autoconf
		pkgs.libtool 
		pkgs.automake
		pkgs.pango
		pkgs.pkg-config
	];
}