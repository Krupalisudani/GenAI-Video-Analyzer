// Additional JavaScript functionality can be added here

// Example: File upload preview
document.addEventListener('DOMContentLoaded', function() {
    const videoFileInput = document.getElementById('videoFile');
    
    if (videoFileInput) {
        videoFileInput.addEventListener('change', function(e) {
            const file = e.target.files[0];
            if (file) {
                // Clear URL input when file is selected
                document.getElementById('videoUrl').value = '';
                
                // Validate file type
                const validTypes = ['video/mp4', 'video/avi', 'video/quicktime', 'video/x-ms-wmv'];
                if (!validTypes.includes(file.type)) {
                    alert('Please select a valid video file (MP4, AVI, MOV, WMV)');
                    e.target.value = '';
                }
                
                // Validate file size (max 100MB)
                const maxSize = 100 * 1024 * 1024; // 100MB in bytes
                if (file.size > maxSize) {
                    alert('File size must be less than 100MB');
                    e.target.value = '';
                }
            }
        });
    }
    
    const videoUrlInput = document.getElementById('videoUrl');
    if (videoUrlInput) {
        videoUrlInput.addEventListener('input', function(e) {
            // Clear file input when URL is entered
            if (e.target.value) {
                document.getElementById('videoFile').value = '';
            }
        });
    }
});

// Add some interactive effects
document.addEventListener('DOMContentLoaded', function() {
    const cards = document.querySelectorAll('.card');
    
    cards.forEach(card => {
        card.addEventListener('mouseenter', function() {
            this.style.transform = 'translateY(-5px)';
            this.style.transition = 'transform 0.3s ease';
        });
        
        card.addEventListener('mouseleave', function() {
            this.style.transform = 'translateY(0)';
        });
    });
});