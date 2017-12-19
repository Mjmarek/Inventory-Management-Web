using System;

using Xamarin.Forms;

namespace Inventory.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetails : ContentPage
    {
        private int? _productId = null;

        public ProductDetails(int? productId)
        {
            InitializeComponent();
            _productId = productId;
            SetupUi();
        }

        public async void SetupUi()
        {
            this.Title = _productId.HasValue ? "Edit Product" : "New Note";

            // If we're creating a new note, disable the Starred switch.
            if (!_noteId.HasValue) fldIsStarred.IsEnabled = false;

            // If we're editing a note, load the note.
            if (_noteId.HasValue)
            {
                // Add delete option.
                this.ToolbarItems.Add(new ToolbarItem("Delete", null, async () =>
                {
                    // Confirm they want to delete.
                    if (await DisplayAlert("Well?", "Are you sure you want to delete this note?", "Yep", "Nope"))
                    {
                        await App.NoteService.Delete(_noteId.Value).ContinueWith(async task =>
                        {
                            if (task.Result)
                            {
                                await DisplayAlert("Great!", "The note has been deleted.", "Okie Dokie");
                                await Navigation.PopAsync(true);
                            }
                            else
                            {
                                await DisplayAlert("Bummer",
                                    "The note could not be deleted. Are you sure it's still there?", "Okie Dokie");
                            }
                        }, TaskScheduler.FromCurrentSynchronizationContext());
                    }
                }));







                ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
