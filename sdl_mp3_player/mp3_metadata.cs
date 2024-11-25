using System.Collections.Generic;

namespace sdl_mp3_player;

public struct mp3_id_tag_header(string mp3_filename)
{
    //first 3 bytes of the file should be hexadecimal 49 44 33 "ID3"
    //next 2 bytes for ID3V2 version
    //next byte contains ID3V2 flags
    //next 4 bytes is tag size.

    
    private string id_tag;
    private int bitrate;
    
}