import React from "react";
import { Link } from "react-router-dom";
import styles from "./WelcomePage.module.css";
import LogoLanding from "./LogoLanding.png";

function WelcomePage() {
  return (
    <div className={styles.welcomePage}>
      {/* Top Navigation Bar */}
      <div className={styles.topNav}>
        <img src={LogoLanding} alt="Virtual ID Card Logo" className={styles.logo} />
        <Link to="/" aria-label="Go to Home">
          <button className={styles.topBtn}>Home</button>
        </Link>
        <Link to="/about" aria-label="Learn more about us">
          <button className={styles.topBtn}>About Us</button>
        </Link>
      </div>

      {/* Main Heading */}
      <h1 className={styles.heading}></h1>

      {/* System Description */}
      <p className={styles.description}>
        {/* Welcome to the Virtual ID Card Application System. This platform simplifies the process of applying for and managing digital identification cards. Enjoy a secure, fast, and hassle-free experience while accessing your virtual ID anywhere, anytime. */}
      </p>

      {/* Action Buttons */}
      <div className={styles.mainButtons}>
        <Link to="/register" aria-label="Register an account">
          <button className={`${styles.registerBtn} ${styles.actionBtn}`}>
            Register
          </button>
        </Link>
        <Link to="/login" aria-label="Login to your account">
          <button className={`${styles.loginBtn} ${styles.actionBtn}`}>
            Login
          </button>
        </Link>
      </div>

      {/* Animated Slogan */}
      <div className={styles.sloganWrapper}>
        <p className={styles.slogan}>Experience the Future of Identification - Secure & Seamless!</p>
      </div>
    </div>
  );
}




export default WelcomePage;
