namespace FAS.Core
{
    public interface IFingerprintVerifier
    {
        bool Verify(byte[] arr1, byte[] arr2);
    }
}
