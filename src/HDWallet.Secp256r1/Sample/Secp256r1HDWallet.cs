using HDWallet.Core;

namespace HDWallet.Secp256r1.Sample
{
    public class Secp256r1HDWallet : HDWallet<Secp256r1Wallet>
    {
        private static readonly HDWallet.Core.CoinPath _path = Purpose.Create(PurposeNumber.BIP44).Coin(CoinType.Neo);

        public Secp256r1HDWallet(string words, string seedPassword) : base(words, seedPassword, _path) {}
        public Secp256r1HDWallet(string seed) : base(seed, _path) {}
    }
}