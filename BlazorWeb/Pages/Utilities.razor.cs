using BlazorWeb.Models.Utilities;
using Microsoft.AspNetCore.Components;
using System;
using System.Text;
using CurrieTechnologies.Razor.Clipboard;
using System.Threading.Tasks;

namespace BlazorWeb.Pages
{
    public class UtilitiesBase : ComponentBase
    {
        [Inject] ClipboardService Clipboard { get; set; }

        protected Base64Model Base64EncodeModel = new Base64Model(Base64OperationType.Encode);

        protected Base64Model Base64DecodeModel = new Base64Model(Base64OperationType.Decode);

        protected void HandleBase64EncodeSubmit()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(Base64EncodeModel.Input);
            Base64EncodeModel.Output = Convert.ToBase64String(plainTextBytes);
        }

        protected void HandleBase64DecodeSubmit()
        {
            var base64EncodedBytes = Convert.FromBase64String(Base64DecodeModel.Input);
            Base64DecodeModel.Output = Encoding.UTF8.GetString(base64EncodedBytes);
        }

        protected async Task CopyEncodedToClipboard()
        {
            if (!string.IsNullOrEmpty(Base64EncodeModel.Output))
                await Clipboard.WriteTextAsync(Base64EncodeModel.Output);
        }

        protected async Task CopyDecodedToClipboard()
        {
            if (!string.IsNullOrEmpty(Base64DecodeModel.Output))
                await Clipboard.WriteTextAsync(Base64DecodeModel.Output);
        }
    }
}
