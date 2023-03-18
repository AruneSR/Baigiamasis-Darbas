namespace Framework.POM
{
    internal class Locators
    {
        internal static class Home
        {
            internal static string ImagesLoading = "//*[@class = 'lazy entered loading']";
            internal static string ImagesLoaded = "//*[@class = 'lazy entered loaded']";
            internal static string IframeCriteo = "//*[@title='Criteo DIS iframe']";
            internal static string DivsCriteo = "/html/body/div[@style='display: none;' and not(@class) and not(@id)]";
            internal static string TagsCriteo = "//*[@id='criteo-tags-div']";
            internal static string ModalCookies = "//*[@id='cookiebanner']";
            internal static string ButtonCookiesAllaccept = "//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']";
        }

        internal static class UserAccountFormLogin
        { 
            internal static string ButtonIconUser  = "//*[@class='yp-header-desktop']//*[contains(@class,'user-controls__login')]";
            internal static string ButtonLogin = "//*[@action='/loginform']//*[@type='submit']";
            internal static string InputEmail = "//*[@id='Email']";
            internal static string InputPassword = "//*[@id='Password']";
            internal static string FieldLogOut = "//*[@class='top-bar__link top-bar__logout']";
            internal static string IconLogout = "//*[@class='flaticon-log-out']";
        }

        internal static class Basket
        {
            internal static string ButtonAddToCart = "//*[@id='addToCart']";
            internal static string ButtonDogIcon = "//*[@class='yp-header-desktop']//*[contains(@class,'fal fa-dog')]";
            internal static string ButtonProductGertuves = "//*[@class='yp-header-desktop']//*[contains(@href,'/gertuves-sunims')]";
            internal static string NotificationBar = "//*[@class='notification__content']";
            internal static string ButtonFirstProduct = "//*[@class='product product-item product-item-1723']";
        }

        internal static class SearchFieldProduct
        {
            internal static string ButtonSearch = "//*[@class='yp-header-desktop']//*[@id='small-search-box-form']/button";
            internal static string InputvalueProductName = "//*[@class='yp-header-desktop']//*[@id='small-searchterms']";
            internal static string TotalListOfProducts = "//*[@class='category-products__main']//*[@class='category-products__total']";
            internal static string InputvaluePriceFrom = "//*[@class='filter-range__from']";
            internal static string InputvaluePriceTo = "//*[@class='filter-range__to']";
            internal static string ClearThePriceFrom = "//*[@class='filter-range__from']";
            internal static string ClearThePriceTo = "//*[@class='filter-range__to']";
            internal static string HeadingSearchResults = "//main[contains(@class,'search-page')]//h1";
            internal static string SpanProductPrice = "//*[contains(@class,'product-item')]//*[@class='product__price--regular']";
        }

        internal static class Wishlist
        {
            internal static string ButtonIconCat = "//*[@class='yp-header-desktop']//*[contains(@class,'fal fa-cat')]";
            internal static string ButtonIconHeart = "//*[@class='product__favorite']";
            internal static string ButtonIconWishlist = "//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-love')]"; 
            internal static string ButtonProductGuoliai = "//*[@class='yp-header-desktop']//*[contains(@href,'/guoliai-guoliai-katems')]";
            internal static string MarkedHeartProducts = "//*[@class='wishlist-products']//*[@class='category-products__total']";
            internal static string OverlayAddingToWishlist = "//*[@class='overlay']";
        }

        internal static class AddNewDogToMyPetsInfo
        {
            internal static string ButtonAddNewPet = "//*[@class='account__content']//*[@type='button']";
            internal static string ButtonIconUserAccount = "//*[@class='yp-header-desktop']//*[contains(@class,'flaticon-user')]";
            internal static string ButtonMyPets = "//*[@href='/customer/pets']";
            internal static string InputPetsBreed = "//*[@id='Pet_Breed']";
            internal static string InputPetsName = "//*[@name='Pet.Name']";
            internal static string SelectSpecies = "//*[@id='Pet_PetSpecies']";
            internal static string SelectDay = "//*[@name='Pet.DateOfBirthDay']";
            internal static string SelectMonth = "//*[@name='Pet.DateOfBirthMonth']";
            internal static string SelectYear = "//*[@name='Pet.DateOfBirthYear']";
            internal static string ButtonToSave = "//*[@class='form__controls']//*[@type='submit']";
            internal static string NotificationBar = "//*[@id='notificationBar']/div/div[2]";
            internal static string FormNewPet = "//*[contains(@class,'form__new-pet')]";
        }
    }
}
