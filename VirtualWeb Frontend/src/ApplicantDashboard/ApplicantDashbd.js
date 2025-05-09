import React, { useState } from "react";
import styles from "./ApplicantDashbd.module.css";

const ApplicantDashbd = () => {
  // User profile state
  const [name, setName] = useState("");
  const [idNumber, setIdNumber] = useState("");
  const [image, setImage] = useState("https://via.placeholder.com/150");
  const [status, setStatus] = useState(""); // Could be "Generated" or "Error"
  const [editing, setEditing] = useState(false);
  const [newName, setNewName] = useState(name);

  // Handle profile image change
  const handleImageChange = (event) => {
    const file = event.target.files[0];
    if (file) {
      const imageUrl = URL.createObjectURL(file);
      setImage(imageUrl);
    }
  };

  // Save profile changes
  const saveChanges = () => {
    setName(newName);
    setEditing(false);
  };

  // Handle logout
  const handleLogout = () => {
    alert("Logged out successfully!");
    
  };

  return (
    <div className={styles.dashboardContainer}>
      {/* Profile Summary */}
      <div className={styles.profileSection}>
        <h2>Applicant Dashboard</h2>

        {/* Profile Image */}
        <div className={styles.imageWrapper}>
          <label htmlFor="profileImage">
            <img src={image} alt="Profile" className={styles.profileImage} />
            <div className={styles.uploadOverlay}>Add</div>
          </label>
          <input
            type="file"
            id="profileImage"
            accept="image/*"
            className={styles.fileInput}
            onChange={handleImageChange}
          />
        </div>

        {/* Profile Details */}
        <div className={styles.profileDetails}>
          <p><strong>ID Number:</strong> {idNumber}</p>

          {editing ? (
            <div className={styles.editContainer}>
          
              <input
                type="text"
                placeholder="Modify name"
                value={newName}
                onChange={(e) => setNewName(e.target.value)}
                className={styles.inputField}
              />
              <button className={styles.saveButton} onClick={saveChanges}>
                Save
              </button>
            </div>
          ) : (
            <>
              <p><strong>Name:</strong> {name}</p>
              <button className={styles.editButton} onClick={() => setEditing(true)}>
                Edit Profile
              </button>
            </>
          )}
        </div>
      </div>

      {/* Visual ID Status */}
      <div className={styles.statusSection}>
        <h3>Visual ID Status</h3>
        <p className={styles.statusText}>
          {status === "Processing" && <span className={styles.processing}>Processing...</span>}
          {status === "Generated" && <span className={styles.generated}>Generated</span>}
          {status === "Error" && <span className={styles.error}>Error in ID Generation</span>}
        </p>
      </div>

      {/* Logout Button */}
      <button className={styles.logoutButton} onClick={handleLogout}>
        Logout
      </button>
    </div>
  );
};

export default ApplicantDashbd;
