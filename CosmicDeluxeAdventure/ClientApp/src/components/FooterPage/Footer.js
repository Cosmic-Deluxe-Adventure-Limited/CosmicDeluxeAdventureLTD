import React from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import {
  faFacebook,
  faTwitter,
  faInstagram,
  faYelp
} from '@fortawesome/free-brands-svg-icons';
import '../FooterPage/Footer.scss';

const Footer = () => {
  return (
    <div className="Footer" >
      <footer>
          <h2>Lets Travel To Space Together</h2>
          <h4>About Cosmic Deluxe Adventure Limited</h4>
          <h4>Space Service</h4>

          <h4>Follow us</h4>
          <div className="contact-link">
         <a id="icon" href="https://www.facebook.com"
            className="facebook social">
            <FontAwesomeIcon icon={faFacebook} size="2x" />
          </a>
          <a id="icon" href="https://www.twitter.com"
            className="twitter social">
            <FontAwesomeIcon icon={faTwitter} size="2x" />
          </a>
          <a id="icon" href="https://www.instagram.com"
            className="instagram social">
            <FontAwesomeIcon icon={faInstagram} size="2x" />
          </a>
         <a id="icon" href="https://www.yelp.com"
            className="yelp social">
            <FontAwesomeIcon icon={faYelp} size="2x" />
          </a>
          </div>
          <p><a href="https://www.google.com/search?q=iss&sxsrf=ALeKk02ZpN0pCQX72p28PLf55OTeoYI1bw:1622067783949&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjn88CwsejwAhUrHDQIHW7uC3QQ_AUoAnoECAIQBA&biw=1440&bih=684#imgrc=xVdTS24AXW6kcM">Space Ships to ISS | </a>
          <a href="https://www.google.com/search?q=mars&tbm=isch&ved=2ahUKEwjO2aizsejwAhWDrZ4KHVSZBIIQ2-cCegQIABAA&oq=mars&gs_lcp=CgNpbWcQAzIECCMQJzIECCMQJzIHCAAQsQMQQzIHCAAQsQMQQzIECAAQQzIICAAQsQMQgwEyBwgAELEDEEMyCAgAELEDEIMBMgQIABBDMgIIADoFCAAQsQNQj9wCWITgAmCX4QJoAHAAeACAAVqIAYwCkgEBNJgBAKABAaoBC2d3cy13aXotaW1nwAEB&sclient=img&ei=TcquYI7_MoPb-gTUspKQCA&bih=684&biw=1440#imgrc=VZ_636wtWAtaZM">Space Ships To Mars | </a> 
          <a href="https://www.google.com/search?q=saturn&tbm=isch&ved=2ahUKEwj_0bDJsejwAhUVq54KHVjzClEQ2-cCegQIABAA&oq=saturn&gs_lcp=CgNpbWcQAzIHCAAQsQMQQzIFCAAQsQMyBwgAELEDEEMyBQgAELEDMgcIABCxAxBDMgUIABCxAzIFCAAQsQMyBwgAELEDEEMyBwgAELEDEEMyBQgAELEDOgQIIxAnOgQIABBDOggIABCxAxCDAToCCABQqGFYmWhgjm9oAHAAeACAAT2IAcsCkgEBNpgBAKABAaoBC2d3cy13aXotaW1nwAEB&sclient=img&ei=fMquYP-jBpXW-gTY5quIBQ&bih=684&biw=1440#imgrc=cimrhpX0xa2I9M">Space Ships To Saturn | </a> 
          <a href="https://www.google.com/search?q=jupiter&tbm=isch&ved=2ahUKEwjmisDQsejwAhVSlJ4KHX_pAkkQ2-cCegQIABAA&oq=ju&gs_lcp=CgNpbWcQARgAMgcIABCxAxBDMgQIABBDMgQIABBDMgQIABBDMgQIABBDMggIABCxAxCDATIFCAAQsQMyBAgAEEMyCAgAELEDEIMBMgQIABBDOgIIAFDotwFYqrkBYJbEAWgAcAB4AIABQ4gBd5IBATKYAQCgAQGqAQtnd3Mtd2l6LWltZ8ABAQ&sclient=img&ei=i8quYKaZAtKo-gT_0ovIBA&bih=684&biw=1440#imgrc=Iw4RG0OvV0gn8M">Space Ships To Jupiter</a></p>
          <p>&copy; 2021 Cosmic Deluxe Adventure Limited. All rights reserved.</p>

      </footer>
    </div>
  );
}

export default Footer;