@Code
    ViewData("Title") = "Home Page"
End Code

<div>
    @*Opening paragraph*@
    <h1 class="h1 text-center">Your Next Co-pack Manufacturing Partner</h1>
    <br />
    <br />
    <br />
    <div>
        <p class="pstyle">
            Welcome to Empire Manufacturing, your trusted co-pack manufacturing partner. As a family-owned and operated business, we take pride in developing strong relationships with our clients, and providing high-quality manufacturing and packaging services. At Empire Manufacturing, we specialize in powder-filled stick packs, powder-filled stand-up pouches, liquid jars (6oz and 8oz), and various capsules and tablets. Our focus is on producing products quickly and safely, without sacrificing quality.
            Our strengths lie in our small size, which allows us to communicate effectively with our clients and provide personalized attention to their needs. Our commitment to making high-quality products is reflected in our state-of-the-art facilities, which use the latest technologies to ensure consistency and accuracy.
        </p>
    </div>
    <div>
        <br />
        <br />
        <img class="page-breaker" src="~/Content/Pictures/genericWarehouse.jpg" alt="warehouse picture" />
        <br />
        <br />
    </div>
    <br />
    <br />
    <br />
</div>
<div runat="server">
    @*javascript for the product descriptions*@
    <script type="text/javascript">
        //The description for stick packs
        function stickPackOver() {
            document.getElementById('productDescription').innerHTML = "<p class='pstyle'>Stick packs are a popular and convenient packaging option for many products. They are pre-portioned and easy to take on the go, making them an ideal choice for dietary supplements, powders, and other products that need to be measured out precisely. At Empire Manufacturing, we offer powder-filled stick packs in a variety of sizes, so you can choose the one that best fits your needs. Our stick packs are designed to keep your products fresh and protected, ensuring that they maintain their quality and efficacy over time.</p>";
            document.getElementById('stickText').setAttribute('class', 'pic-text pic-text-back pic-text-stick fadeIn');
        }
        //The description for stand pouches
        function standPouchOver() {
            document.getElementById('productDescription').innerHTML = "<p class='pstyle'>Stand-up pouches are another excellent packaging option for many products. They are lightweight, durable, and easy to store, making them a great choice for protein powders, formulas, and other powdered items. At Empire Manufacturing, we offer powder-filled stand-up pouches in a range of sizes and styles. Our pouches are designed to keep your products fresh and protected, with features such as resealable zippers and oxygen absorbing desicants.</p>";
            document.getElementById('pouchText').setAttribute('class', 'pic-text pic-text-back pic-text-pouch fadeIn');
        }
        //The description for bottles
        function bottlePictureOver() {
            document.getElementById('productDescription').innerHTML = "<p class='pstyle'>At Empire Manufacturing, we offer liquid-filled jars in both 6oz and 8oz sizes, with a variety of closure options to choose from. Our jars are made from high-quality materials and designed to protect your products from light, moisture, and other environmental factors that can degrade their quality over time.</p>";
            document.getElementById('bottleText').setAttribute('class', 'pic-text pic-text-back pic-text-bottle fadeIn');
        }
        //The description for pills
        function pillPictureOver() {
            document.getElementById('productDescription').innerHTML = "<p class='pstyle'>Capsules and tablets are a common form of dietary supplement and medication. At Empire Manufacturing, we offer comprehensive services for manufacturing and packaging capsules and tablets. We can work with you to manufacture various types of capsules and tablets, choose the right packaging options, and ensure that your products meet all regulatory requirements. Our state-of-the-art facilities and experienced team make us a trusted partner for all your capsule and tablet manufacturing needs.</p><p class='pill-credit'>Image by upklyak on Freepik</p>";
            document.getElementById('pillText').setAttribute('class', 'pic-text pic-text-back pic-text-pill fadeIn');
        }
    </script>
</div>
@*Pictures of the services offered, soft gell capp, stand pouches, stick packs, and bottles*@
<br />
<br />
<br />
<div class="container-fluid">
    <div class="row">
        <div class="col-lg-3 picStyle">
            <p class="pstyle text-center">STICK PACKS</p>
            <img ID="stickPack" onmouseover="stickPackOver()" class="img-responsive center-block img-rounded" src="~/Content/Pictures/stickPack.jpg" alt="Stick Pack" />
        </div>
        <div class="col-lg-3 picStyle text-primary">
            <p class="pstyle text-center">STAND POUCHES</p>
            <img ID="standPouch" onmouseover="standPouchOver()" class="img-responsive center-block img-rounded" src="~/Content/Pictures/standPouch.jpg" alt="Stand Pouch" />
        </div>
        <div class="col-lg-3 picStyle">
            <p class="pstyle text-center">BOTTLES</p>
            <img ID="bottlePicture" onmouseover="bottlePictureOver()" class="img-responsive center-block img-rounded" src="~/Content/Pictures/bottle.jpg" alt="Bottle" />
        </div>
        <div class="col-lg-3 picStyle">
            <p class="pstyle text-center">CAPSULES & TABLETS</p>
            <img id="pillPicture" onmouseover="pillPictureOver()" runat="server" class="img-responsive center-block img-rounded" src="~/Content/Pictures/pills.jpg" alt="Pills Picture" />
        </div>
    </div>
</div>
<br />
<br />
<br />
<div>
    <p class="pstyle" id="productDescription">Discover more about our amazing products and services by scrolling over our images.</p>
</div>
<br />
<br />
<br />