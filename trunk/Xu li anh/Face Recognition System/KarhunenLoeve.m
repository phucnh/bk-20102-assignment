% Karhunen-Loeve, for face recognition 
% By Alex Chirokov, Alex.Chirokov@gmail.com
clear all;

% Load training database (training set)
k = 0;
for i=1:1:3
    for j=1:1:10
        filename  = sprintf('C:\\Users\\PHUC\\Desktop\\KL_based Face Recognition System\\att_faces\\s%d\\%d.pgm',i,j); %traning database path
        image_data = imread(filename);
        k = k + 1;
        x(:,k) = image_data(:); 
        anot_name(k,:) = sprintf('%2d:%2d',i,j);   % for plot annotations
     end;
end;
nImages = k;                     %total images
imsize = size(image_data);       %image size
nPixels = imsize(1)*imsize(2);   %total pixels per image
x = double(x)/255;               

%Calculate mean_face - average_face
avrgx = mean(x')';

%mean derivation form
for i=1:1:nImages
    x(:,i) = x(:,i) - avrgx; % substruct the average
end;
subplot(2,2,1); imshow(reshape(avrgx, imsize)); title('mean face')

%Calculate covariance matrix
cov_mat = x'*x;
[V,D] = eig(cov_mat);         %eigenvalues
V = x*V*(abs(D))^-0.5;               
subplot(2,2,2); imshow(ScaleImage(reshape(V(:,nImages  ),imsize))); title('1st eigen face');
subplot(2,2,3); imshow(ScaleImage(reshape(V(:,nImages-1),imsize))); title('2st eigen face');
%subplot(2,2,3); imshow(ScaleImage(reshape(V(:,nImages-2),imsize))); title('3st eigen face');
subplot(2,2,4); plot(diag(D)); title('Eigen values');


KLCoef =  x'*V; 

%representation image
%KLCoef(:,1:1:1)= 0;  % filtration
image_index = 5;  %index of representation image
reconst = V*KLCoef';
diff = abs(reconst(:,image_index) - x(:,image_index));
strdiff_sum = sprintf('delta per pixel: %e',sum(sum(diff))/nPixels);
figure;
subplot(2,2,1); imshow((reshape(avrgx+reconst(:,image_index), imsize))); title('Reconstructed');
subplot(2,2,2); imshow((reshape(avrgx+x(:,image_index), imsize)));title('original');
subplot(2,2,3); imshow(ScaleImage(reshape(diff, imsize))); title(strdiff_sum);

for i=1:1:nImages
    dist(i) = sqrt(dot(KLCoef(image_index,:)-KLCoef(i,:), KLCoef(image_index,:)-KLCoef(i,:))); %euclidean
end;
subplot(2,2,4); plot(dist,'.-'); title('euclidean distance from the first face');

% MODE: face:expression
%VD : s1/2.pgm
figure;
show_faces = 1:1:nImages/2;
plot(KLCoef(show_faces,nImages), KLCoef(show_faces,nImages-1),'.'); title('Desomposition: Numbers indicate (Face:Expression)');
for i=show_faces
    name = anot_name(i,:);
    text(KLCoef(i,nImages), KLCoef(i,nImages-1),name,'FontSize',8);
end;


%image_index = 12;
for i=1:1:nImages
    dist_comp(i) = sqrt(dot(KLCoef(image_index,:)-KLCoef(i,:), KLCoef(image_index,:)-KLCoef(i,:))); %euclidean
    strDist(i) = cellstr(sprintf('%2.2f\n',dist_comp(i)));
end;
[sorted, sorted_index] = sort(dist_comp); % sort distances
figure; % open new figure
for i=1:1:9
    subplot(3,3,i); imshow((reshape(avrgx+x(:,sorted_index(i)), imsize))); title(strDist(sorted_index(i)));
end;


