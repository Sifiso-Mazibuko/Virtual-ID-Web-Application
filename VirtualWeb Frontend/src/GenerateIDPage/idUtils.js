export const generateID = (setIdImage, setLoading) => {
  setTimeout(() => {
    setIdImage("/assets/generated-id.png"); // Replace with actual image path
    setLoading(false);
  }, 3000);
};

export const downloadID = (idImage) => {
  if (idImage) {
    const link = document.createElement("a");
    link.href = idImage;
    link.download = "Generated_ID.png";
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
  }
};
