#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class AppleTangle
    {
        private static byte[] data = System.Convert.FromBase64String("aXbHhUBObUBHQ0NBRER2x/Bcx/VLQE9swA7AsUtHR0NDRkXER0dGGjIvIC8lJzIjZiQ/ZicoP2Y2JzQyQ0ZFxEdJRnbER0xExEdHRqLX70/NX8+Yvw0qs0HtZHZErl54vhZPlY9fNLMbSJM5Gd20Y0X8E8kLG0u393YeqhxCdMou9clbmCM1uSEYI/rER0ZAT2zADsCxJSJDR3bHtHZsQDYqI2YUKSkyZgUHdlhRS3ZwdnJ0QkBVRBMVd1V2V0BFE0JMVUwHNjY8dsRHMHZIQEUTW0lHR7lCQkVER0nbe7VtD25cjriI8/9InxhakI17QEUTW0hCUEJSbZYvAdIwT7iyLctZ151YARatQ6sYP8JrrXDkEQoTqjExaCc2NiojaCUpK2knNjYqIyUn+LI13aiUIkmNPwlynuR4vz65LY45B+7ev5eMINpiLVeW5f2iXWyFWWpmJSM0Mi8gLyUnMiNmNikqLyU/09g8SuIBzR2SUHF1jYJJC4hSL5cyLik0LzI/d1B2UkBFE0JFVUsHNvFd+9UEYlRsgUlb8AvaGCWODcZRaAbgsQELOU4YdllARRNbZUJedlAf4UNPOlEGEFdYMpXxzWV9AeWTKZ9wOYfBE5/h3/90BL2ekzfYOOcUQao7f8XNFWaVfoL3+dwJTC25bbo2KiNmBSM0Mi8gLyUnMi8pKGYHM05tQEdDQ0FER1BYLjIyNjV8aWkxD54w2XVSI+cx0o9rREVHRkflxEchyU7yZrGN6mpmKTbweUd2yvEFiXbEQv12xEXl5kVER0RER0R2S0BPThh2xEdXQEUTW2ZCxEdOdsRHQnZmBQd2xEdkdktAT2zADsCxS0dHR3DfCms+8avK3Zq1Md20MJQxdgmHdXAcdiR3TXZPQEUTQkBVRBMVd1UqI2YPKCVod2B2YkBFE0JNVVsHNoYldTGxfEFqEK2cSWdInPw1XwnzxlJtli8B0jBPuLIty2gG4LEBCznJNccmgF0dT2nU9L4CDrYmfthTs2B2YkBFE0JNVVsHNjYqI2YFIzQy7po4ZHOMY5OfSZAtkuRiZVex5+pAdklARRNbVUdHuUJDdkVHR7l2WyQqI2Y1MicoIic0ImYyIzQrNWYnFCMqLycoJSNmKShmMi4vNWYlIzQDOFkKLRbQB8+CMiRNVsUHwXXMx1nDxcNd33sBcbTv3QbIapL31lSeNCclMi8lI2Y1MicyIysjKDI1aHZmKSBmMi4jZjIuIyhmJzY2Ki8lJ3N0d3J2dXAcUUt1c3Z0dn90d3J2InNlUw1TH1v10rGw2tiJFvyHHhbt5TfUARUTh+lpB/W+vaU2i6DlCntgIWbMdSyxS8SJmK3lab8VLB0iP2YnNTUzKyM1ZiclJSM2MicoJSNQdlJARRNCRVVLBzY2KiNmFCkpMmzADsCxS0dHQ0NGdiR3TXZPQEUTKCJmJSkoIi8yLykoNWYpIGYzNSNmJygiZiUjNDIvIC8lJzIvKShmNmKkrZfxNplJA6dhjLcrPquh81FRdldARRNCTFVMBzY2KiNmDyglaHfzfOuySUhG1E33Z1BoMpN6S50kUC8gLyUnMi8pKGYHMzIuKTQvMj93FuzMk5yiupZPQXH2MzNn");
        private static int[] order = new int[] { 37,47,39,14,16,19,26,34,26,39,28,22,30,15,36,50,17,44,18,19,59,31,52,58,51,44,35,27,31,37,33,50,48,35,36,57,48,55,50,54,55,42,50,44,49,46,50,48,59,51,56,55,57,59,55,56,59,59,58,59,60 };
        private static int key = 70;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
