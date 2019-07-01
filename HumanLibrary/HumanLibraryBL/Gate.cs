using System;

namespace HumanLibraryBL
{
        public class Gate
        {
            public Gate()
            {

            }

            public Gate(int id, string code, string description)
            {
                Id = id;
                Code = code;
                Description = description;

            }
            public int Id { get; set; }
            public string Code { get; set; }
            public string Description { get; set; }
        }
    }
