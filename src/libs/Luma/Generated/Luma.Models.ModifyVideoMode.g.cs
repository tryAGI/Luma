
#nullable enable

namespace Luma
{
    /// <summary>
    /// The mode of the modify video
    /// </summary>
    public enum ModifyVideoMode
    {
        /// <summary>
        /// 
        /// </summary>
        Adhere1,
        /// <summary>
        /// 
        /// </summary>
        Adhere2,
        /// <summary>
        /// 
        /// </summary>
        Adhere3,
        /// <summary>
        /// 
        /// </summary>
        Flex1,
        /// <summary>
        /// 
        /// </summary>
        Flex2,
        /// <summary>
        /// 
        /// </summary>
        Flex3,
        /// <summary>
        /// 
        /// </summary>
        Reimagine1,
        /// <summary>
        /// 
        /// </summary>
        Reimagine2,
        /// <summary>
        /// 
        /// </summary>
        Reimagine3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyVideoModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyVideoMode value)
        {
            return value switch
            {
                ModifyVideoMode.Adhere1 => "adhere_1",
                ModifyVideoMode.Adhere2 => "adhere_2",
                ModifyVideoMode.Adhere3 => "adhere_3",
                ModifyVideoMode.Flex1 => "flex_1",
                ModifyVideoMode.Flex2 => "flex_2",
                ModifyVideoMode.Flex3 => "flex_3",
                ModifyVideoMode.Reimagine1 => "reimagine_1",
                ModifyVideoMode.Reimagine2 => "reimagine_2",
                ModifyVideoMode.Reimagine3 => "reimagine_3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyVideoMode? ToEnum(string value)
        {
            return value switch
            {
                "adhere_1" => ModifyVideoMode.Adhere1,
                "adhere_2" => ModifyVideoMode.Adhere2,
                "adhere_3" => ModifyVideoMode.Adhere3,
                "flex_1" => ModifyVideoMode.Flex1,
                "flex_2" => ModifyVideoMode.Flex2,
                "flex_3" => ModifyVideoMode.Flex3,
                "reimagine_1" => ModifyVideoMode.Reimagine1,
                "reimagine_2" => ModifyVideoMode.Reimagine2,
                "reimagine_3" => ModifyVideoMode.Reimagine3,
                _ => null,
            };
        }
    }
}