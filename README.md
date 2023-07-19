# Kelime Konumu Bulma

Bu C# repo, kullanıcının girdiği bir cümlede aranan bir kelimenin cümlenin başında mı yoksa sonunda mı olduğunu bulmak için bir örnek içermektedir. Bu örnek, `With` yapısını kullanır ve basit bir algoritma kullanarak sonuçları belirler.

## Kullanım

1. Repo'yu klonlayın veya ZIP olarak indirin.
2. Projeyi bir C# uyumlu geliştirme ortamında (IDE) açın.
3. Kelimeyi ya da ek'i aratmak istediğiniz cümleyi yazın.
4. Cümlenin başında ya da sonunda olup olmadığını kontrol etmek istediğiniz eki veya kelimeyi yazın ve arama yapın.

   ```C#
   string cumle = "Bu bir örnek cümledir.";
   string arananKelime = "örnek";
   
   bool kelimeCumleninBasinda = false;
   bool kelimeCumleninSonunda = false;
   
   if (cumle.StartsWith(arananKelime))
   {
       kelimeCumleninBasinda = true;
   }
   else if (cumle.EndsWith(arananKelime))
   {
       kelimeCumleninSonunda = true;
   }
   
   Console.WriteLine("Kelime cümlenin başında mı? " + kelimeCumleninBasinda);
   Console.WriteLine("Kelime cümlenin sonunda mı? " + kelimeCumleninSonunda);
