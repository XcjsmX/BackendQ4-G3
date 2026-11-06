using Google.Cloud.Firestore;
namespace BackendQ4_G3PrograWeb.Services;

public class FirebaseService
{
    private readonly FirestoreDb _firestoreDb;

    public FirebaseService()
    {
        var credentialPatch = Path.Combine(AppContext.BaseDirectory, "Config", "firebase-credentials.json");
        
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialPatch);

        _firestoreDb = FirestoreDb.Create("prograwebq4-759");
        
        
    }

    public CollectionReference(string collectionName)
    {
        return _firestoreDb.Collection(collectionName);
    }
}